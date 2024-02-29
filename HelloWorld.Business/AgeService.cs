using System.Diagnostics;

namespace HelloWorld.Business
{
    public class AgeService
    {
        /// <summary>
        /// Will calculate the age by a date of birth (DOB).
        /// </summary>
        /// <param name="dob">The date of birth, which is a <see cref="DateTime"/></param>
        /// <returns>The age calculation, which is a <see cref="int"/></returns>

        public delegate void NotifyAgeCalculated();
        public event NotifyAgeCalculated OnAgeCalculated;

        public int CalculateAge(DateTime dob)
        {
            int age = (int)((DateTime.Now - dob).TotalDays / 365.242199);

            return age;
        }

        public int CalculateAge(int year)
        {
            Debug.WriteLineIf(year <= 1900, "This person is from or before 1900?");

            if (year <= 0)
                throw new Exception("Year can't be 0 or less");

            if (year > DateTime.Now.Year)
                throw new Exception("You can't be born in the future!");

            int age = DateTime.Now.Year - year;

            if (OnAgeCalculated != null)
                OnAgeCalculated.Invoke();

            return age;
        }
    }
}
