using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    static class Data
    {
        public static List<ContactCard> SeedContactCards() =>
            new List<ContactCard>()
            {
                new ContactCard()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    PhoneNumber = "+1-812-JOHN-DOE",
                    Company = "ACME Inc.",
                    Title = "CEO",
                    Email = "john.doe@acme.com"
                },
                new ContactCard()
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    PhoneNumber = "+1-812-JANE-DOE",
                    Company = "ACME Inc.",
                    Title = "CFO",
                    Email = "jane.doe@acme.com",
                },
                new ContactCard()
                {
                    FirstName = "Amy",
                    LastName = "Jackson",
                    PhoneNumber = "+1-812-JKSN-AMY",
                    Company = "ACME Inc.",
                    Title = "Head of HR Departament",
                    Email = "amy.jackson@acme.com",
                    SocialMediaLinks = new List<string>()
                    {
                        "twitter.com/amydoe",
                        "facebook.com/amydoe",
                        "instagram.com/amydoe",
                    },
                    AdditionalPhones = new List<string>
                    {
                        "+1-800-ACME-INC"
                    }
                },
                new ContactCard()
                {
                    FirstName = "Sam",
                    LastName = "Jackson",
                    PhoneNumber = "+1-812-JKSN-SAM",
                    Company = "ACME Inc.",
                    Title = "Head of PR Departament",
                    Email = "sam.jackson@acme.com",
                    SocialMediaLinks = new List<string>()
                    {
                        "twitter.com/theveryrealsamjackson",
                        "facebook.com/jacksonsam",
                        "instagram.com/sam.j",
                        "linkedin.com/sam.jackson"
                    },
                    AdditionalPhones = new List<string>
                    {
                        "+1-800-ACME-INC"
                    }
                },
                new ContactCard()
                {
                    FirstName = "Viktor",
                    LastName = "Jackson",
                    PhoneNumber = "+1-812-JKSN-VIK",
                    Company = "ACME Inc.",
                    Title = "Head of Delivery Dept.",
                    Email = "viktor.jackson@acme.com",
                    AdditionalPhones = new List<string>()
                    {
                        "+1-800-ACME-INC"
                    }
                }
            };

    }
}
