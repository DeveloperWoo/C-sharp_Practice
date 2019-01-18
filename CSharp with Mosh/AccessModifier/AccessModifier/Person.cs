using System;

namespace AccessModifier
{
    public class Person
    {
        private DateTime _birthday;

        public void SetBirthday(DateTime birthday)
        {
            this._birthday = birthday;
        }

        public DateTime GetBirthdate()
        {
            return _birthday;
        }
    }
}
