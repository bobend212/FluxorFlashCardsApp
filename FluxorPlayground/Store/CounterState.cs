using Fluxor;

namespace FluxorPlayground.Store
{
    public record CounterState(int Count);

    public class CounterFeatureState : Feature<CounterState>
    {
        public override string GetName() => "counter!";

        protected override CounterState GetInitialState() => new CounterState(0);
    }
}