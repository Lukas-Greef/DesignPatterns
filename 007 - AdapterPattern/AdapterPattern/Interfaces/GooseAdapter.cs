using AdapterPattern.Interfaces;

namespace AdapterPattern.Interfaces
{
    internal class GooseAdapter : Duck
    {
        private Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public void Quack()
        {
            goose.Honk();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                goose.Fly();
            }
        }
    }
}