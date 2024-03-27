using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace _BackEnd_Assessment
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Content> Contents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Network> Networks { get; set; }

        // Method to populate data in user table
        public void PopulateUserTable()
        {
            var users = new[]
            {
                new User
                {
                    UserName = "Ali Ahmad",
                    FirstName = "Ali",
                    LastName = "Ahmad",
                    ThreeDigitNumber = 123,
                    Wins = 5,
                    Losses = 3
                },
                new User
                {
                    UserName = "Bilal Javeed",
                    FirstName = "Bilal",
                    LastName = "Javeed",
                    ThreeDigitNumber = 456,
                    Wins = 2,
                    Losses = 1
                },
                new User
                {
                    UserName = "Hamza Naveed",
                    FirstName = "Hamza",
                    LastName = "Naveed",
                    ThreeDigitNumber = 789,
                    Wins = 4,
                    Losses = 2
                },
                new User
                {
                    UserName = "Raza Ahad",
                    FirstName = "Raza",
                    LastName = "Ahad",
                    ThreeDigitNumber = 987,
                    Wins = 7,
                    Losses = 6
                },
                new User
                {
                    UserName = "Baber Sitaar",
                    FirstName = "Baber",
                    LastName = "Sitaar",
                    ThreeDigitNumber = 546,
                    Wins = 1,
                    Losses = 3
                },
                new User
                {
                    UserName = "Mudasir Nazer",
                    FirstName = "Mudasir",
                    LastName = "Nazer",
                    ThreeDigitNumber = 466,
                    Wins = 1,
                    Losses = 2
                },
                new User
                {
                    UserName = "Umar Iqbal",
                    FirstName = "Umar",
                    LastName = "Iqbal",
                    ThreeDigitNumber = 444,
                    Wins = 3,
                    Losses = 1
                },
                new User
                {
                    UserName = "Zain Meer",
                    FirstName = "Zain",
                    LastName = "Meer",
                    ThreeDigitNumber = 666,
                    Wins = 7,
                    Losses = 2
                },
                new User
                {
                    UserName = "Asadullah Ch",
                    FirstName = "Asadullah",
                    LastName = "Ch",
                    ThreeDigitNumber = 321,
                    Wins = 2,
                    Losses = 1
                },
                new User
                {
                    UserName = "Fahad Riaz",
                    FirstName = "Fahad",
                    LastName = "Riaz",
                    ThreeDigitNumber = 135,
                    Wins = 7,
                    Losses = 2
                }
            };

            // Add records to Users table
            Users.AddRange(users);

            // Save changes to database
            SaveChanges();
        }

        // Method to populate data in content table with images in byte array
        public void PopulateContentTableWithImages()
        {
            var contents = new List<Content>();

            contents.AddRange(new[]
                  {
            new Content
            {
                Question = "What is this?",
                AnswerA = "Bottle",
                AnswerB = "Cup",
                AnswerC = "Water",
                AnswerD = "Fruit",
                CorrectAnswer = "Bottle",
                Image = GetImageBytes("C:\\Users\\2\\OneDrive\\Desktop\\backendTest\\bottle.jpg"),//image path from local folder
                UserName = "Zain Meer"
            },
            new Content
            {
                Question = "What is this?",
                AnswerA = "Bottle",
                AnswerB = "Cup",
                AnswerC = "Water",
                AnswerD = "Fruit",
                CorrectAnswer = "Cup",
                Image = GetImageBytes("C:\\Users\\2\\OneDrive\\Desktop\\backendTest\\cup.jpg"),
                UserName = "Fahad Riaz"
            },
            new Content
            {
                Question = "What is this?",
                AnswerA = "Bottle",
                AnswerB = "Cup",
                AnswerC = "Water",
                AnswerD = "Fruit",
                CorrectAnswer = "Water",
                Image = GetImageBytes("C:\\Users\\2\\OneDrive\\Desktop\\backendTest\\water.jpg"),
                UserName ="Asadullah Ch"
            },
            new Content
            {
                Question = "What is this?",
                AnswerA = "Bottle",
                AnswerB = "Cup",
                AnswerC = "Water",
                AnswerD = "Fruit",
                CorrectAnswer = "Fruit",
                Image = GetImageBytes("C:\\Users\\2\\OneDrive\\Desktop\\backendTest\\apple.jpg"),
                UserName = "Fahad Riaz"
            },
            new Content
            {
                Question = "What is this?",
                AnswerA = "Bottle",
                AnswerB = "Cup",
                AnswerC = "Dog",
                AnswerD = "Fruit",
                CorrectAnswer = "Dog",
                Image = GetImageBytes("C:\\Users\\2\\OneDrive\\Desktop\\backendTest\\dog.jpg"),
                UserName = "Umar Iqbal"
            },
            new Content
            {
                Question = "What is this?",
                AnswerA = "Bottle",
                AnswerB = "Animal",
                AnswerC = "Water",
                AnswerD = "Fruit",
                CorrectAnswer = "Animal",
                Image = GetImageBytes("C:\\Users\\2\\OneDrive\\Desktop\\backendTest\\lion.jpg"),
                UserName = "Zain Meer"
            },
            new Content
            {
                Question = "What color is this?",
                AnswerA = "Black",
                AnswerB = "White",
                AnswerC = "Red",
                AnswerD = "Yellow",
                CorrectAnswer = "Black",
                Image = GetImageBytes("C:\\Users\\2\\OneDrive\\Desktop\\backendTest\\black.jpg"),
                UserName = "Ali Ahmad"
            },
            new Content
            {
                Question = "What color is this?",
                AnswerA = "Red",
                AnswerB = "Black",
                AnswerC = "Water",
                AnswerD = "Pink",
                CorrectAnswer = "Red",
                Image = GetImageBytes("C:\\Users\\2\\OneDrive\\Desktop\\backendTest\\red.jpg"),
                UserName = "Asadullah Ch"
            },
            new Content
            {
                Question = "What color is this?",
                AnswerA = "Pink",
                AnswerB = "Cup",
                AnswerC = "Water",
                AnswerD = "Green",
                CorrectAnswer = "Green",
                Image = GetImageBytes("C:\\Users\\2\\OneDrive\\Desktop\\backendTest\\green.jpg"),
                UserName = "Ali Ahmad"
            },
            new Content
            {
                Question = "What is this?",
                AnswerA = "Bottle",
                AnswerB = "Cup",
                AnswerC = "Water",
                AnswerD = "Fruit",
                CorrectAnswer = "Fruit",
                Image = GetImageBytes("C:\\Users\\2\\OneDrive\\Desktop\\backendTest\\banana.jpg"),
                UserName = "Umar Iqbal"
            }
        });

            // Add recirds to table
            Contents.AddRange(contents);

            // Save changes to database
            SaveChanges();
        }

        // Method to populate data in network table
        public void PopulateNetworkTable()
        {
            var networks = new[]
            {
                new Network
                {
                    Code = "NTK1",
                    NetworkName = "Test_Network"
                },
                new Network
                {
                    Code = "F6DH",
                    NetworkName = "Secure_4G"
                },
                new Network
                {
                    Code = "A5H2",
                    NetworkName = "Open_Network"
                },
                new Network
                {
                    Code = "K6W2",
                    NetworkName = "House_Connection"
                },
                new Network
                {
                    Code = "N3W2",
                    NetworkName = "Wifi_2"
                },
                new Network
                {
                    Code = "NTf2",
                    NetworkName = "Local_2"
                },
                new Network
                {
                    Code = "GhW2",
                    NetworkName = "4G "
                },
                new Network
                {
                    Code = "N4J2",
                    NetworkName = "PTCL"
                },
                new Network
                {
                    Code = "uTW2",
                    NetworkName = "Library_Network"
                },
                new Network
                {
                    Code = "N2W2",
                    NetworkName = "Open_Net"
                }
            };

            Networks.AddRange(networks);
            SaveChanges();
        }

        // Method to convert image file to byte array
        private byte[] GetImageBytes(string imagePath)
        {
            using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                byte[] imageData = new byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
                return imageData;
            }
        }
    }
}
