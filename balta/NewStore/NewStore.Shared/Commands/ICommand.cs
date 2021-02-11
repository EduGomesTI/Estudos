namespace NewStore.Shared.Commands
{
    public interface ICommand
    {
        //* Método adicionado para ter compatibilidade no curso.
        //* Pretendo utilizar validações nas entidades e VOs e nos Handlers tornando assim redundante
        //* qualquer validação nos Commands.
        bool Valid();
    }
}