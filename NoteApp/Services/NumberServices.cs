using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteApp.Models;

namespace NoteApp.Services
{
    public class NumberServices
    {
        public Number createNumber(string input)
        {
            Number number = new Number(input);

            return number;
        }
    }
}
