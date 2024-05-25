using Library.DB;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Library.Admin.UserControls
{
    public partial class AddBook : UserControl
    {
        public string Title;
        public int AuthorId;
        public int GenreId;
        public string Description;
        public bool Available;
        public bool SaveClicked;



        private string temporaryImagePath;
        public AddBook()
        {

            InitializeComponent();
            string[] authors = DbBook.GetAllAuthors();
            Array.Sort(authors);
            comboAuthor.Items.AddRange(authors);

            string[] genres = DbBook.GetAllGenres();
            Array.Sort(genres);
            comboGenre.Items.AddRange(genres);
            comboAvailable.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Title = textTitle.Text.Trim();
            Description = textDescription.Text.Trim();
            Available = (comboAvailable.SelectedItem.ToString() == "Да");

            if (CheckFields())
            {
                AuthorId = DbBook.GetAuthorId(comboAuthor.SelectedItem.ToString());
                GenreId = DbBook.GetGenreId(comboGenre.SelectedItem.ToString());
                if (SaveImage(Title))
                {
                    string extension = Path.GetExtension(temporaryImagePath);
                    string imagePath = $"\\Resources\\Covers\\{Title}{extension}";
                    bool bookAdded = DbBook.AddBook(Title, AuthorId, GenreId, Description, Available, imagePath);
                    if (bookAdded)
                    {
                        MessageBox.Show("Книга успешно добавлена");
                        textTitle.Text = string.Empty;
                        textDescription.Text = string.Empty;
                        comboAvailable.SelectedIndex = -1;
                        comboAuthor.SelectedIndex = -1;
                        comboGenre.SelectedIndex = -1;
                        panel1.BackgroundImage = global::Library.Properties.Resources.DEFAULT_ADD;

                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Изображение не выбрано, все равно продолжить?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Успех");
                    }
                }
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    // Проверка размера изображения
                    using (Image image = Image.FromFile(selectedImagePath))
                    {
                        if (image.Width != 200 || image.Height != 300)
                        {
                            MessageBox.Show("Изображение должно быть размером 200x300 пикселей.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    temporaryImagePath = selectedImagePath;
                    panel1.BackgroundImage = Image.FromFile(temporaryImagePath);
                }
            }
        }


        private bool SaveImage(string title)
        {
            string rootDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            string saveDirectory = Path.Combine(rootDirectory, "Resources\\Covers");

            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }

            if (!string.IsNullOrEmpty(temporaryImagePath))
            {

                string fileName = title + Path.GetExtension(temporaryImagePath);
                string saveFilePath = Path.Combine(saveDirectory, fileName);

                try
                {
                    File.Copy(temporaryImagePath, saveFilePath, true);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении изображения: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }


        private bool CheckFields()
        {
            if (string.IsNullOrEmpty(Title))
            {
                MessageBox.Show("Название не введнно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboAuthor.SelectedItem == null)
            {
                MessageBox.Show("Автор не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboGenre.SelectedItem == null)
            {
                MessageBox.Show("Жанр не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(Description))
            {
                MessageBox.Show("Описание не введено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


    }
}
