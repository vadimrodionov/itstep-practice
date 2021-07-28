using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ContactCard
    {
        const string binaryStartSeparator = "CCBEG";
        const string binaryEndSeparator = "CCFIN";

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public List<string> AdditionalPhones { get; set; } = new List<string>();
        public List<string> SocialMediaLinks { get; set; } = new List<string>();

        public void WriteToBinaryStream(BinaryWriter writer)
        {
            writer.Write(binaryStartSeparator);

            writer.Write(FirstName);
            writer.Write(LastName);
            writer.Write(Company);
            writer.Write(Title);
            writer.Write(PhoneNumber);
            writer.Write(Email);

            writer.Write(AdditionalPhones?.Count ?? 0);
            if (AdditionalPhones is not null && AdditionalPhones.Count > 0)
                foreach (var p in AdditionalPhones)
                    writer.Write(p);

            writer.Write(SocialMediaLinks?.Count ?? 0);
            if (SocialMediaLinks is not null && SocialMediaLinks.Count > 0)
                foreach (var s in SocialMediaLinks)
                    writer.Write(s);

            writer.Write(binaryEndSeparator);
        }

        public void ReadFromBinaryStream(BinaryReader reader)
        {
            // looking for data start separator
            var startPosition = reader.BaseStream.Position;
            var startSep = reader.ReadString();
            if (startSep != binaryStartSeparator)
                throw new IOException($"Failed to find a start of {nameof(ContactCard)} entity at source stream, position {startPosition}");

            // reading data
            var temp = new ContactCard();
            try
            {
                temp.FirstName = reader.ReadString();
                temp.LastName = reader.ReadString();
                temp.Company = reader.ReadString();
                temp.Title = reader.ReadString();
                temp.PhoneNumber = reader.ReadString();
                temp.Email = reader.ReadString();

                temp.AdditionalPhones = new List<string>();
                var additionalPhonesCount = reader.ReadInt32();
                for (int i = 0; i < additionalPhonesCount; i++)
                    temp.AdditionalPhones.Add(reader.ReadString());

                temp.SocialMediaLinks = new List<string>();
                var socialMediaLinksCount = reader.ReadInt32();
                for (int i = 0; i < socialMediaLinksCount; i++)
                    temp.SocialMediaLinks.Add(reader.ReadString());
            }
            catch (IOException ex)
            {
                throw new IOException($"Failed to read {nameof(ContactCard)} entity - data is corrupted", ex);
            }

            // looking for data end separator
            var endPosition = reader.BaseStream.Position;
            var endSep = reader.ReadString();
            if (endSep != binaryEndSeparator)
                throw new IOException($"Failed to find an end of {nameof(ContactCard)} entity at source stream, position {endPosition}");

            // filling actual values
            temp.CopyTo(this);
        }

        public override string ToString() =>
            new StringBuilder()
                .AppendLine($"Name: {FirstName} {LastName}")
                .AppendLine($"Company: {Company}")
                .AppendLine($"Title: {Title}")
                .AppendLine($"Phone number: {PhoneNumber}")
                .AppendLine($"Email: {Email}")
                .AppendLine($"Additional phone numbers: ")
                .AppendLine($"  - {String.Join("\n  - ", AdditionalPhones)}")
                .AppendLine($"Social media links:")
                .AppendLine($"  - {String.Join("\n  - ", SocialMediaLinks)}")
                .ToString();

        private void CopyTo(ContactCard dest)
        {
            dest.FirstName = FirstName;
            dest.LastName = LastName;
            dest.Company = Company;
            dest.Title = Title;
            dest.PhoneNumber = PhoneNumber;
            dest.Email = Email;
            dest.AdditionalPhones = AdditionalPhones.ToList();
            dest.SocialMediaLinks = SocialMediaLinks.ToList();
        }
    }
}
