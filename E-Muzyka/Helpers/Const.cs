using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Muzyka.Helpers
{
    public static class Const
    {
        public const string OnlyLetters = @" ^ ([A - Za - zzżźćńółęąśŻŹĆĄŚĘŁÓŃ] +)$";
        public const string OnlyNumbers = @"^[0-9]+";
        public const string LettersNumbers = @"^ ([^A-Za-- zzżźćńółęąśŻŹĆĄŚĘŁÓŃ 0-9])$";
    }
}