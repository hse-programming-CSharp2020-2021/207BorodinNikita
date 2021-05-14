using System;
using System.Text;

namespace EschoZadachka
{
    class VetoEventArgs : EventArgs
    {
        public string Proposal { get; set; }
        public VetoVoter VetoBy { get; set; }
    }

    class VetoComission
    {
        public event EventHandler<VetoEventArgs> OnVote;

        public VetoEventArgs Vote(string proposal)
        {
            var args = new VetoEventArgs() { Proposal = proposal };
            OnVote?.Invoke(this, args);

            return args;
        }
    }

    class VetoVoter
    {
        public string Name { get; set; }

        public void VetoVoteHandler(object sender, VetoEventArgs args)
        {
            Random random = new Random();

            if(random.Next(0, 5) == 0)
                args.VetoBy ??= this;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            VetoComission comission = new VetoComission();

            VetoVoter[] voters = new VetoVoter[5];

            for (int i = 0; i < voters.Length; i++)
            {
                voters[i] = new VetoVoter() { Name = GetName() };
                comission.OnVote += voters[i].VetoVoteHandler;
            }

            VetoEventArgs result = comission.Vote("Запретить перед сессией студентам доступ в интернет, чтобы они не смотрели видео с котиками?");

            Console.WriteLine($"Вопрос голосования: \"{result.Proposal}\"\n");
            Console.WriteLine($"Вето наложено: {result.VetoBy?.Name ?? "а никем не наложено (все согласны)"}");
        }

        static string GetName()
        {
            Random random = new Random();
            StringBuilder name = new StringBuilder();

            name.Append((char)random.Next('A', 'Z'));

            for (int i = 0; i < random.Next(0, 10); i++)
                name.Append((char)random.Next('a', 'z'));

            return name.ToString();
        }
    }
}
