using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShortLink.Core.Models
{
    public class LinkEntity
    {
        Random randome = new Random();

        [Column("LinkId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Link's name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string? Url { get; set; }
        public string? ShortLink { get; set; }

        public LinkEntity(string? url)
        {
            Id = randome.Next(10000000);
            Url = url;
            ShortLink = LinkGenerator.RandomLinkCreator();
        }

    }
    public class LinkGenerator
    {
        public static string RandomLinkCreator()
        {
            Random _random = new Random();
            var builder = new StringBuilder(8);

            char offset = 'A';
            const int lettersOffset = 26;
            char offset2 = 'a';
            char offset3 = '0';
            const int numbersOffset = 9;


            for (var i = 0; i < 12; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                var num = _random.Next(0, 3);
                if (num == 0)
                {
                    @char = (char)_random.Next(offset, offset + lettersOffset);
                }
                if (num == 1)
                {
                    @char = (char)_random.Next(offset2, offset2 + lettersOffset);
                }
                if (num == 2)
                {
                    @char = (char)_random.Next(offset3, offset3 + numbersOffset);
                }

                builder = builder.Append(@char);
            }

            return builder.ToString();
        }
    }
}

