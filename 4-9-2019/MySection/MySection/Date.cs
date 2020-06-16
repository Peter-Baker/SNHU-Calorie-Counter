using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using NutritionCalculator;
using System.Windows.Forms;

namespace MySection
{
    class Date
    {

        private String path;
        private User name;
        private ArrayList breakfast;
        private ArrayList lunch;
        private ArrayList dinner;
        private ArrayList snacks;
        private ArrayList workouts;
        //Files will be saved as, MONTH.DAY.YEAR.txt

        public Date(String path, User name, ArrayList breakfast, ArrayList lunch, ArrayList dinner, ArrayList snacks, ArrayList workouts)
        {
            this.path = path;
            this.name = name;
            this.breakfast = breakfast;
            this.lunch = lunch;
            this.dinner = dinner;
            this.snacks = snacks;
            this.workouts = workouts;

            string[] lines = new string[breakfast.Count + lunch.Count + dinner.Count + snacks.Count + workouts.Count + 5];

            lines[0] = "breakfast";
            int temp = 1;
            for(int i = 0; i < breakfast.Count; i++)
            {
                lines[temp] = breakfast[i].ToString();
                temp++;
            }
            lines[temp] = "lunch";
            temp++;
            for(int i = 0; i < lunch.Count; i++)
            {
                lines[temp] = lunch[i].ToString();
                temp++;
            }
            lines[temp] = "dinner";
            temp++;
            for(int i = 0; i < dinner.Count; i++)
            {
                lines[temp] = dinner[i].ToString();
                temp++;
            }
            lines[temp] = "snacks";
            temp++;
            for(int i = 0; i < snacks.Count; i++)
            {
                lines[temp] = snacks[i].ToString();
                temp++;
            }
            lines[temp] = "workouts";
            temp++;
            for(int i = 0; i < workouts.Count; i++)
            {
                lines[temp] = workouts[i].ToString();
                temp++;
            }
            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllLines(path, lines);
        }
    }
}
