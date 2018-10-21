using MyIdeaPool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyIdeaPool
{
    internal class Validation
    {
        private static readonly int maxFieldLen = 255;

        public static void ValidateEmail(string email)
        {
            var addr = new System.Net.Mail.MailAddress(email);
        }

        public static void ValidateNonEmptyField(string fieldName, string fieldValue)
        {
            if (string.IsNullOrWhiteSpace(fieldValue)) throw new Exception(fieldName + " cannot be empty");
        }

        public static void ValidateFieldLen(string fieldName, string fieldValue)
        {
            if (fieldValue.Length > maxFieldLen) throw new Exception(fieldName + " length must be max " + maxFieldLen);
        }

        public static void ValidateFieldRange(string fieldName, int fieldValue, int min, int max)
        {
            if (fieldValue < min || fieldValue > max) throw new Exception(fieldName + " value must be in the range " + min + " to " + max);
        }
        public static void ValidatePassword(string password)
        {
            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit)) return;

            throw new Exception("Password must be at least 8 characters, including 1 uppercase letter, 1 lowercase letter, and 1 number)");
        }
        public static void Validate<T>(T t)
        {
            if (typeof(T).Equals(typeof(User))) {
                var user = t as User;
                ValidateEmail(user.email);
                ValidateNonEmptyField("Name", user.name);
                ValidatePassword(user.password);
            }
            else
            if (typeof(T).Equals(typeof(NewIdea)))
            {
                var idea = t as NewIdea;
                ValidateFieldLen("content", idea.content);
                ValidateFieldRange("impact", idea.impact, 1, 10);
                ValidateFieldRange("ease", idea.ease, 1, 10);
                ValidateFieldRange("confidence", idea.confidence, 1, 10);
            }

        }
    }
}