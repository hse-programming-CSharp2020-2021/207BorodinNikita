using System;

namespace ZadachkaVotTakovoPlana
{
    class PlayIsStartedEventArgs : EventArgs
    {
        public int Number { get; }

        public PlayIsStartedEventArgs(int number)
        {
            Number = number;
        }
    }

    class Bandmaster
    {
        public event EventHandler<PlayIsStartedEventArgs> PlayIsStartedEvent;
        public void StartPlay(int number)
        {
            PlayIsStartedEventArgs args = new PlayIsStartedEventArgs(number);

            PlayIsStartedEvent?.Invoke(this, args);
        }
    }
    abstract class OrchestraPlayer
    {
        protected int Name { get; }

        public OrchestraPlayer()
        {
            Name = new Random().Next(1, 1000);
        }

        public abstract void PlayIsStartedEventHandler(object sender, PlayIsStartedEventArgs args);
    }

    class Violinist : OrchestraPlayer
    {
        public override void PlayIsStartedEventHandler(object sender, PlayIsStartedEventArgs args)
        {
            Console.WriteLine($"Violinist {Name} plays composition #{args.Number}: La-la!");
        }
    }

    class Hornist : OrchestraPlayer
    {
        public override void PlayIsStartedEventHandler(object sender, PlayIsStartedEventArgs args)
        {
            Console.WriteLine($"Hornist {Name} plays composition #{args.Number}: Du-du-du!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Bandmaster master = new Bandmaster();

            OrchestraPlayer[] orc = new OrchestraPlayer[10];

            for (int i = 0; i < orc.Length; i++)
            {
                if (random.Next(0, 2) == 0)
                    orc[i] = new Violinist();

                else orc[i] = new Hornist();

                master.PlayIsStartedEvent += orc[i].PlayIsStartedEventHandler;
            }

            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("*******************************************");
                master.StartPlay(random.Next(2, 6));
            }
        }
    }
}
