namespace WeddingApi.Controllers.Helper
{
    public class EmailTemplates
    {
        public static string GetBaseSubject(string name, string language)
        {
            return language == "en"
                ? $"Thank you for confirming your attendance {name}!"
                : $"Obrigado por confirmar a sua presença {name}!";
        }

        public static string GetIsAttendingBody(string name, string language)
        {
            return language == "en"
                ? $"Dear {name},\n\nThank you very much for being present on such an important day in our lives. " +
                  "Please don't forget to mark this special date for us on your calendar, so you don't forget it.\n\n" +
                  "To help you remember, our wedding will be on September 12, 2025, starting around 5 PM at the Vandelli Botanical Garden, " +
                  "located at Calçada do Galvão E, 1400-171 Lisbon.\n https://www.google.com/maps/place/Vandelli+Botanical+Garden/@38.7067187,-9.2017967,17z/data=!3m1!4b1!4m6!3m5!1s0xd1ecb4279c1a8cd:0x800851f444044593!8m2!3d38.7067187!4d-9.2017967!16s%2Fg%2F11s9dk7_r6?entry=ttu&g_ep=EgoyMDI0MTIxMS4wIKXMDSoASAFQAw%3D%3D \n\n" +
                  "If you would like to give us a wedding gift, we would like to remind you that you can do so through the following methods:\n\n" +
                  "MBWAY: 918960273 / 925355133\n" +
                  "IBAN: PT50 0010 0000 6354 2650 0011 2\n\n" +
                  "We hope to see you at our wedding!\n\nBest regards,\n\nRicardo and Carolina"
                : $"Caro\\a {name},\n\n Muito obrigado por estar presente neste dia tão importante para as nossas vidas. " +
                  "Não se esqueça de marcar esta data tão especial para nós no seu calendário, de forma a não se esquecer da data.\n\n" +
                  "Para não se esquecer, o nosso casamento será no dia 12 de Setembro de 2025, a começar perto das 17h no Vandelli Botanical Garden, " +
                  "localizado Calçada do Galvão E, 1400-171 Lisboa.\n https://www.google.com/maps/place/Vandelli+Botanical+Garden/@38.7067187,-9.2017967,17z/data=!3m1!4b1!4m6!3m5!1s0xd1ecb4279c1a8cd:0x800851f444044593!8m2!3d38.7067187!4d-9.2017967!16s%2Fg%2F11s9dk7_r6?entry=ttu&g_ep=EgoyMDI0MTIxMS4wIKXMDSoASAFQAw%3D%3D \n\n" +
                  "Caso deseje dar-nos algum presente para o nosso casamento, relembramos que nos pode deixar-nos uma lembrança através dos seguintes métodos:\n\n" +
                  "MBWAY: 918960273 / 925355133\n" +
                  "IBAN: PT50 0010 0000 6354 2650 0011 2\n\n" +
                  "Esperamos vê-lo\\a no nosso casamento!\n\n Com os melhores cumprimentos,\n\n Ricardo e Carolina";
        }
        public static string GetIsNotAttendingBody(string name, string language)
        {
            return language == "en"
                ? $"Dear {name},\n\nWe would like to thank you in advance for confirming that you will not be able to attend our wedding. " +
                  "It is with regret that we will not have you with us at this important event for us, but we hope to see you soon so that we can celebrate this new chapter in our life.\n\n" +
                  "If you eventually manage to attend this event, please contact us in advance so that we can accommodate one more person at our wedding.\n\n" +
                  "Also, If you would like to give us a wedding gift, we would like to remind you that you can leave us a token of appreciation through the following methods:\n\n" +
                  "MBWAY: 918960273 / 925355133\n" +
                  "IBAN: PT50 0010 0000 6354 2650 0011 2\n\n" +
                  "We hope to see you soon!\n\nBest regards,\n\nRicardo and Carolina"
                : $"Caro\\a {name},\n\n Agradecemos desde já o facto de nos ter confirmado que não puderá estar presente no nosso casamento. " +
                  "É com pena que nossa que não contaremos consigo neste evento importante para nós mas esperamos vê-lo/a em breve de forma a podermos celebrar esta nova etapa na nossa vida.\n\n" +
                  "Se eventualmente conseguir comparecer neste evento, por favor entre em contacto connosco com alguma antecedência de forma a podermos acomodar mais uma pessoa no nosso casamento.\n\n" +
                  "Caso deseje dar-nos algum presente para o nosso casamento, relembramos que nos pode deixar-nos uma lembrança através dos seguintes métodos:\n\n" +
                  "MBWAY: 918960273 / 925355133\n" +
                  "IBAN: PT50 0010 0000 6354 2650 0011 2\n\n" +
                  "Esperamos vê-lo\\a em breve!\n\n Com os melhores cumprimentos,\n\n Ricardo e Carolina";
        }
    }
}