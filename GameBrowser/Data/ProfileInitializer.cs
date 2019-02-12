using GameBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameBrowser.Data
{
    public class ProfileInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Profiles.Any())
            {
                return;
            }

            var profile = new Profile[]

            {
                new Profile { NickName = "42ne", Record = 300, Score = 1200},
                new Profile { NickName = "DrummaBanger", Record = 10, Score = 120},

            };
            foreach (Profile s in profile)
            {
                context.Profiles.Add(s);
            }
            context.SaveChanges();
        }
    }
}
