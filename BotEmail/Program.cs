using BotEmail;

var email = new Email(iMAPHOST: "outlook.office365.com", iMAP_USER: "joao.24110059@alunos.unisagrado.edu.br", iMAP_PASSWORD: "010992Jo$%");
await email.Connect();
var messages = email.GetMessages();

Console.ReadLine();