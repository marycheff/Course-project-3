using Library.Classes;
using Library.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Library.Book
{
    public partial class EditBookForm : Form
    {
        public string Title { get; private set; }
        public int AuthorId { get; private set; }
        public int GenreId { get; private set; }
        public string Description { get; private set; }
        public bool Available { get; private set; }
        public bool SaveClicked { get; private set; }



        private string temporaryImagePath;
        private readonly string imageFileName;

        public EditBookForm(int id)
        {
            InitializeComponent();
            global::Book book = DbBook.GetBook(id);
            this.Text = $"Библиотека - Правка книги \"{book.Title}\"";
            textTitle.Text = book.Title;

            List<Author> authors = DbBook.GetAllAuthors();
            authors = authors.OrderBy(a => a.Name).ToList();
            comboAuthor.Items.Clear();

            foreach (Author author in authors)
            {
                comboAuthor.Items.Add(author.Name);
            }
            comboAuthor.SelectedItem = DbBook.GetAuthorById(book.AuthorId);


            List<Genre> genres = DbBook.GetAllGenres();
            genres = genres.OrderBy(g => g.Name).ToList(); 
            comboGenre.Items.Clear(); 
            foreach (var genre in genres)
            {
                comboGenre.Items.Add(genre.Name); 
            }
            comboGenre.SelectedItem = DbBook.GetGenreById(book.GenreId);


            if (DbBook.GetAvailabilityId(id))
            {
                comboAvailable.SelectedIndex = 0;
            }
            else
            {
                comboAvailable.SelectedIndex = 1;
            }

            textDescription.Text = book.Description;
            string rootDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            string imagePath = rootDirectory + Path.Combine(rootDirectory, book.CoverImagePath);

            if (File.Exists(imagePath))
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    using (Image image = Image.FromStream(fs))
                    {
                        panel1.BackgroundImage = new Bitmap(image);
                    }
                }
            }
            imageFileName = Path.GetFileName(imagePath);
        }


        private void btnEditImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    temporaryImagePath = openFileDialog.FileName;
                    panel1.BackgroundImage = Image.FromFile(temporaryImagePath);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Title = textTitle.Text.Trim();
            AuthorId = DbBook.GetAuthorId(comboAuthor.SelectedItem.ToString());
            GenreId = DbBook.GetGenreId(comboGenre.SelectedItem.ToString());
            Description = textDescription.Text.Trim();
            Available = (comboAvailable.SelectedItem.ToString() == "Да");


            if (!string.IsNullOrEmpty(temporaryImagePath))
            {
                string rootDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
                string saveDirectory = Path.Combine(rootDirectory, "Resources\\Covers");
                string oldImagesDirectory = Path.Combine(saveDirectory, "Old");

                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }

                if (!Directory.Exists(oldImagesDirectory))
                {
                    Directory.CreateDirectory(oldImagesDirectory);
                }

                string fileName = imageFileName;
                string saveFilePath = Path.Combine(saveDirectory, fileName);

                if (File.Exists(saveFilePath))
                {
                    string timeStamp = DateTime.Now.ToString("yyyy.MM.dd_HH-mm-ss");
                    string fileExtension = Path.GetExtension(fileName);
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
                    string newOldFileName = $"{fileNameWithoutExtension} {timeStamp}{fileExtension}";
                    string oldFilePath = Path.Combine(oldImagesDirectory, newOldFileName);

                    try
                    {
                        File.Move(saveFilePath, oldFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при перемещении старого изображения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                try
                {
                    File.Copy(temporaryImagePath, saveFilePath);
                    MessageBox.Show("Изображение успешно сохранено.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении изображения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SaveClicked = true;
            MessageBox.Show("Изменения сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }





    }
}
