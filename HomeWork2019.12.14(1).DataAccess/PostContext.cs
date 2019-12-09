namespace HomeWork2019._12._14_1_.DataAccess
{
    using HomeWork2019._12._14_1_.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PostContext : DbContext
    {
        // Контекст настроен для использования строки подключения "PostContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "HomeWork2019._12._14_1_.DataAccess.PostContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "PostContext" 
        // в файле конфигурации приложения.
        public PostContext()
            : base("name=PostContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}