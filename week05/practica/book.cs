using System;
namespace lybrary_demo
{
    public class Book
    {
    private string _title = "";
    private string _author= "";
    
    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetTitle()
    {
    return _title;
    } 

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetBookInfo()
    {
        return $"Title: {_title}, Author: {_author}";
    }

    }
}