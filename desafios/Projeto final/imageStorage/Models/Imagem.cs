namespace imageStorage.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }
        
        public string ContentType { get; set; }

        public byte[] Dados { get; set; }
    }
}


/*
 	Id int IDENTITY(1,1) NOT NULL,
	Nome nvarchar(150) NOT NULL,
	ContentType nvarchar(50) NOT NULL,
	Dados varbinary(max) NULL,
 */