using HomeWork2019._12._14_1_.AbstractModels;

namespace HomeWork2019._12._14_1_.Models
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public int LikeCoutnt { get; set; }
    }
}
