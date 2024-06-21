namespace FactoryDesignPattern
{
    class MiddleEndPc : IComputer
    {
        private readonly string GpuSpecs;

        public MiddleEndPc()
        {
            this.GpuSpecs = "GTX 2070 ti";
        }

        public string GPU()
        {
            return this.GpuSpecs;
        }

        public string PCType()
        {
            return "Middle-End";
        }
    }
}
