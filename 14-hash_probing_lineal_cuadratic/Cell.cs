namespace HashProbingLinearCuadratic
{
    enum state
    {
        empty, busy, deleted
    }

    public class Cell
    {
        private int key;
        private string data;
        private state myState;

        public int Key { get => this.key; set =>this.key = value; }
        public string Data { get => this.data; set => this.data = value; }
        internal state MyState { get => this.myState; set => this.myState = value; }

        public Cell ()
        {
            this.key = 0;
            this.data = "";
            this.myState = state.empty;
        }
    }
}