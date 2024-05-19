using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class BookInfo
{
    private int id;
    private string title;
    private int authorId;
    private int genreId;
    private string description;
    private bool available;
    private string coverImagePath;


    private string authorName;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    public int AuthorId
    {
        get { return authorId; }
        set { authorId = value; }
    }
    public int GenreId
    {
        get { return genreId; }
        set { genreId = value; }
    }
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public bool Available
    {
        get { return available; }
        set { available = value; }
    }

    public string CoverImagePath
    {
        get { return coverImagePath; }
        set { coverImagePath = value; }
    }
    public string AuthorName
    {
        get { return authorName; }
        set { authorName = value; }
    }


}

