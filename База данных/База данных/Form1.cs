using Microsoft.EntityFrameworkCore.Storage;
using Npgsql;
using System.Security.Cryptography.X509Certificates;

namespace База_данных
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Table_1.ReadOnly = true;
            Table_BookClients.ReadOnly = true;
            Table_Clients.ReadOnly = true;


            using (var context = new Context())
            {
                var books = from b in context.Book select b;
                Table_1.DataSource = books.ToList();

                var Bookclients = from c in context.Library select c;
                Table_BookClients.DataSource = Bookclients.ToList();

                var clients = from c in context.NameClients select c;
                Table_Clients.DataSource = clients.ToList();
                comboBoxClients.DataSource = clients.ToList();
                comboBoxClients.DisplayMember = "Name";
                comboBoxClients.ValueMember = "Id";
            }


            librarybookclient();
            ComboboxBookView();
            ComboboxClientView();
        }

        private void AddText_Click(object sender, EventArgs e)
        {
            if (BookGenre.Text != "" && BookName.Text != "" && AuthorName.Text != "")
            {
                using (var context = new Context())
                {
                    Book Book = new Book();
                    Book.Book_genre = BookGenre.Text;
                    Book.Name_Books = BookName.Text;
                    Book.Books_Author = AuthorName.Text;


                    if (BookGenre.Text == "Роман" || BookGenre.Text == "Ужасы" ||
                        BookGenre.Text == "Блокбастер" || BookGenre.Text == "Фэнтези" ||
                        BookGenre.Text == "Энциклопедия" || BookGenre.Text == "Утопия" ||
                        BookGenre.Text == "Антиутопия" || BookGenre.Text == "Сказки" ||
                        BookGenre.Text == "Рассказы" || BookGenre.Text == "Драмы" ||
                        BookGenre.Text == "Мелодрамы")
                    {


                        context.Book.Add(Book);
                        context.SaveChanges();

                        var books = from b in context.Book select b;
                        Table_1.DataSource = books.ToList();


                    }
                    else
                    {

                        MessageBox.Show("Такого жанра не существует", "Предупреждение");
                    }


                }
            }
            else
            {
                MessageBox.Show("Заполните поля для добавления книги", "Предупреждение");
            }


        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            if (NameClients.Text != "" && SureNAme.Text != "" && NamberPHone.Text != "")
            {
                using (var context = new Context())
                {
                    NameClients nameClients = new NameClients();
                    nameClients.Name = NameClients.Text;
                    nameClients.SureName = SureNAme.Text;
                    nameClients.NumberPhone = NamberPHone.Text;
                    context.NameClients.Add(nameClients);

                    context.SaveChanges();

                    var clients = from c in context.NameClients select c;
                    Table_Clients.DataSource = clients.ToList();

                }
            }
            else
            {
                MessageBox.Show("Заполните поля для добавления клиента", "Предупреждение");
            }
        }
        

        public void librarybookclient()
        {
            using (var context = new Context())
            {
                var Bookslients = from c in context.Library

                                  join Book in context.Book
                                  on c.BookId equals Book.Id
                                  join NameClients in context.NameClients
                                  on c.ClientsId equals NameClients.Id
                                  select new
                                  {
                                      c.Id,
                                      BookID = Book.Id + " " + Book.Name_Books + " " + Book.Books_Author,
                                      ClientsID = NameClients.Name + " " + NameClients.SureName + " " + NameClients.NumberPhone,
                                  };

                Table_BookClients.DataSource = Bookslients.ToList();

            }
        }





        public void ComboboxBookView()
        {
            using (var context = new Context())
            {
                var ComboBooks = from b in context.Book
                                select new
                                {
                                    BooksID = b.Id,
                                    Name = b.Id + " | " + b.Name_Books + " | " + b.Books_Author
                                };
                comboBoxBook.DataSource = ComboBooks.ToList();
                comboBoxBook.DisplayMember = "Name";
                comboBoxBook.ValueMember = "BooksID";
            }
        }
        public void ComboboxClientView()
        {
            using (var context = new Context())
            {
                var ComboClients = from c in context.NameClients
                                select new
                                {
                                    ClientsID = c.Id,
                                    Name = c.Id + " | " + c.Name + " | " + c.SureName
                                };
                comboBoxClients.DataSource = ComboClients.ToList();
                comboBoxClients.DisplayMember = "Name";
                comboBoxClients.ValueMember = "ClientsID";
            }
        }
        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Search(radioButton1.Text);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Search(radioButton2.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Search(radioButton3.Text);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Search(radioButton4.Text);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Search(radioButton5.Text);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Search(radioButton6.Text);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Search(radioButton7.Text);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Search(radioButton8.Text);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Search(radioButton10.Text);
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            Search(radioButton11.Text);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            Search(radioButton12.Text);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            Search(radioButton13.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                List<Library> library = new List<Library>();
                foreach (DataGridViewRow row in Table_BookClients.SelectedRows)
                {
                    var deleted = (int)row.Cells[0].Value;
                    library.Add(context.Library.First(s => s.Id == deleted));
                }
                context.Library.RemoveRange(library);
                context.SaveChanges();
                var libraryview = from b in context.Library select b;
                Table_BookClients.DataSource = libraryview.ToList();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                Library library = new Library();
                library.ClientsId = Convert.ToInt32(comboBoxClients.SelectedValue);
                library.BookId = Convert.ToInt32(comboBoxBook.SelectedValue);



                var libraryView = from b in context.Library select b;
                Table_BookClients.DataSource = libraryView.ToList();


                context.Library.Add(library);
                context.SaveChanges();
                
            }
        }

        public void Search(string name)
        {
            SearchdataGridView1.ReadOnly = true;
            SearchdataGridView1.ClearSelection();
            string Genre = new string(name);
            using (var context = new Context())
            {
                var books = from b in context.Book where b.Book_genre == Genre select b;
                SearchdataGridView1.DataSource = books.ToList();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            using (var context = new Context())
            {
                List<Book> Book = new List<Book>();
                foreach (DataGridViewRow row in Table_1.SelectedRows)
                {
                    var deleted = (int)row.Cells[0].Value;
                    Book.Add(context.Book.First(s => s.Id == deleted));
                }


                context.Book.RemoveRange(Book);
                context.SaveChanges();
                var books = from b in context.Library select b;
                Table_1.DataSource = books.ToList();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            using (var context = new Context())
            {
                List<NameClients> nameClients = new List<NameClients>();
                foreach (DataGridViewRow row in Table_Clients.SelectedRows)
                {
                    var deleted = (int)row.Cells[0].Value;
                    nameClients.Add(context.NameClients.First(s => s.Id == deleted));
                }


                context.NameClients.RemoveRange(nameClients);
                context.SaveChanges();
                var clients = from NC in context.NameClients select NC;
                Table_Clients.DataSource = clients.ToList();

            }
        }
    }
}
