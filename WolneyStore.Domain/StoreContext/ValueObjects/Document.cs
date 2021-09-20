using FluentValidator;
using FluentValidator.Validation;

namespace WolneyStore.Domain.StoreContext.ValueObjects
{
    public class Document : Notifiable
    {
        public Document(string number)
        {
            Number = number;

            AddNotifications(new ValidationContract()
                .IsTrue(Validade(Number), "Document", "CPF inválido!")
                );
        }

        public string Number { get; private set; }

        public override string ToString()
        {
            return Number;
        }

        // Validar CPF (pegar uma função por aí)
        public bool Validade(string number)
        {
            if (number.Length != 11)
                return false;
            return true;
        }
    }
}
