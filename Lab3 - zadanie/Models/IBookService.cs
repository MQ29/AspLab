﻿using BookData.Entities;

namespace Lab3zadanie.Models
{
    public interface IBookService
    {
        int Add(Book book);
        void Delete(int id);
        void Update(Book book);
       List<Book> FindAll();
        Book? FindById(int id);
        List<PublisherEntity> FindAllPublishers();
    }
}
