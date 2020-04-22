using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoqTraining
{
    public interface IServiceDAO
    {
        void SaveToDatabase(User user);
    }
}
