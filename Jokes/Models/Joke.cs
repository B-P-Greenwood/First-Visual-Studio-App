using System.ComponentModel.DataAnnotations;

namespace Jokes.Models
{
    public class Joke
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string JokeQuestion { get; set; }
        [Required]
        public string JokeAnswer { get; set; }
        [Required]
        public string JokeAuthor { get; set; }  
        public Joke()
        {

        }
    }
}
