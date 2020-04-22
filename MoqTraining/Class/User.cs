using MoqTraining;
using System;
using System.Collections.Generic;
using System.Text;
using XUnit.Moq.Produtos;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Age { get; set; }
        private IServiceDAO dao;

        public void save(User user)
        {
            dao.SaveToDatabase(user);
        }

        public void setDao(IServiceDAO dao)
        {
            this.dao = dao;
        }
    }

}