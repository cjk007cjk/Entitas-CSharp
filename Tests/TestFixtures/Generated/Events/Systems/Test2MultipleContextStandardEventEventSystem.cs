//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class Test2MultipleContextStandardEventEventSystem : Entitas.ReactiveSystem<Test2Entity> {

    readonly Entitas.IGroup<Test2Entity> _listeners;

    public Test2MultipleContextStandardEventEventSystem(Contexts contexts) : base(contexts.test2) {
        _listeners = contexts.test2.GetGroup(Test2Matcher.Test2MultipleContextStandardEventListener);
    }

    protected override Entitas.ICollector<Test2Entity> GetTrigger(Entitas.IContext<Test2Entity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(Test2Matcher.MultipleContextStandardEvent)
        );
    }

    protected override bool Filter(Test2Entity entity) {
        return entity.hasMultipleContextStandardEvent;
    }

    protected override void Execute(System.Collections.Generic.List<Test2Entity> entities) {
        foreach (var e in entities) {
            var component = e.multipleContextStandardEvent;
            foreach (var listenerEntity in _listeners) {
                foreach (var listener in listenerEntity.test2MultipleContextStandardEventListener.value) {
                    listener.OnMultipleContextStandardEvent(e, component.value);
                }
            }
        }
    }
}
