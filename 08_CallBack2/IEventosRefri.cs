namespace _08_CallBack2
{
    interface IEventosRefri
    {
        // Aqui definimos los eventos que tendrá el refri
        void EReservasBajas(int pKilos);

        // Adicionamos otro evento
        void EDescongelado(int pGrados);
    }
}
