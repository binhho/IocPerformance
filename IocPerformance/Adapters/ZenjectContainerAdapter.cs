using System;
using IocPerformance.Classes.Child;
using IocPerformance.Classes.Complex;
using IocPerformance.Classes.Conditions;
using IocPerformance.Classes.Dummy;
using IocPerformance.Classes.Generics;
using IocPerformance.Classes.Multiple;
using IocPerformance.Classes.Properties;
using IocPerformance.Classes.Standard;
using IocPerformance.Interception;
using Zenject;

namespace IocPerformance.Adapters
{
    public sealed class ZenjectContainerAdapter : ContainerAdapterBase
    {
        private DiContainer container;

        public override string PackageName
        {
            get { return "Zenject"; }
        }

        public override string Version
        {
            get
            {
                return "3.0";
            }
        }

        public override string Url
        {
            get { return "http://zenject.com"; }
        }

        public override bool SupportsInterception
        {
            get { return false; }
        }

        public override bool SupportsPropertyInjection
        {
            get { return true; }
        }

        public override bool SupportGeneric
        {
            get { return false; }
        }

        public override bool SupportsConditional
        {
            get { return true; }
        }

        public override bool SupportsMultiple
        {
            get { return false; }
        }

        public override bool SupportsChildContainer
        {
            get { return true; }
        }

        public override IChildContainerAdapter CreateChildContainerAdapter()
        {
            return new ZenjectChildContainerAdapter(this.container.CreateSubContainer());
        }

        public override object Resolve(Type type)
        {
            return this.container.Resolve(type);
        }

        public override void Dispose()
        {
            // Allow the container and everything it references to be garbage collected.
            //this.container.Dispose();
            this.container = null;
        }

        public override void Prepare()
        {
            this.PrepareBasic();

            this.RegisterPropertyInjection();
            //this.RegisterOpenGeneric();
            this.RegisterConditional();
            this.RegisterMultiple();
            //this.RegisterInterceptor();
        }

        public override void PrepareBasic()
        {
            this.container = new DiContainer();

            this.RegisterDummies();
            this.RegisterStandard();
            this.RegisterComplexObject();
        }

        private void RegisterDummies()
        {
            this.container.Bind<IDummyOne>().ToTransient<DummyOne>();
            this.container.Bind<IDummyTwo>().ToTransient<DummyTwo>();
            this.container.Bind<IDummyThree>().ToTransient<DummyThree>();
            this.container.Bind<IDummyFour>().ToTransient<DummyFour>();
            this.container.Bind<IDummyFive>().ToTransient<DummyFive>();
            this.container.Bind<IDummySix>().ToTransient<DummySix>();
            this.container.Bind<IDummySeven>().ToTransient<DummySeven>();
            this.container.Bind<IDummyEight>().ToTransient<DummyEight>();
            this.container.Bind<IDummyNine>().ToTransient<DummyNine>();
            this.container.Bind<IDummyTen>().ToTransient<DummyTen>();
        }

        private void RegisterStandard()
        {
            this.container.Bind<ISingleton1>().ToSingle<Singleton1>();
            this.container.Bind<ISingleton2>().ToSingle<Singleton2>();
            this.container.Bind<ISingleton3>().ToSingle<Singleton3>();
            this.container.Bind<ITransient1>().ToTransient<Transient1>();
            this.container.Bind<ITransient2>().ToTransient<Transient2>();
            this.container.Bind<ITransient3>().ToTransient<Transient3>();
            this.container.Bind<ICombined1>().ToTransient<Combined1>();
            this.container.Bind<ICombined2>().ToTransient<Combined2>();
            this.container.Bind<ICombined3>().ToTransient<Combined3>();
        }

        private void RegisterComplexObject()
        {
            this.container.Bind<IFirstService>().ToSingle<FirstService>();
            this.container.Bind<ISecondService>().ToSingle<SecondService>();
            this.container.Bind<IThirdService>().ToSingle<ThirdService>();
            this.container.Bind<ISubObjectA>().ToTransient<SubObjectA>();
            this.container.Bind<ISubObjectB>().ToTransient<SubObjectB>();
            this.container.Bind<ISubObjectC>().ToTransient<SubObjectC>();
            this.container.Bind<IComplex1>().ToTransient<Complex1>();
            this.container.Bind<IComplex2>().ToTransient<Complex2>();
            this.container.Bind<IComplex3>().ToTransient<Complex3>();
        }

        private void RegisterPropertyInjection()
        {
            this.container.Bind<IComplexPropertyObject1>().ToTransient<ComplexPropertyObject1>();
            this.container.Bind<IComplexPropertyObject2>().ToTransient<ComplexPropertyObject2>();
            this.container.Bind<IComplexPropertyObject3>().ToTransient<ComplexPropertyObject3>();
            this.container.Bind<IServiceA>().ToSingle<ServiceA>();
            this.container.Bind<IServiceB>().ToSingle<ServiceB>();
            this.container.Bind<IServiceC>().ToSingle<ServiceC>();
            this.container.Bind<ISubObjectOne>().ToTransient<SubObjectOne>();
            this.container.Bind<ISubObjectTwo>().ToTransient<SubObjectTwo>();
            this.container.Bind<ISubObjectThree>().ToTransient<SubObjectThree>();
        }

        private void RegisterOpenGeneric()
        {
            this.container.Bind(typeof(IGenericInterface<>)).ToTransient(typeof(GenericExport<>));
            this.container.Bind(typeof(ImportGeneric<>)).ToTransient();
        }

        private void RegisterConditional()
        {
            this.container.Bind<ImportConditionObject1>().ToTransient<ImportConditionObject1>();
            this.container.Bind<ImportConditionObject2>().ToTransient<ImportConditionObject2>();
            this.container.Bind<ImportConditionObject3>().ToTransient<ImportConditionObject3>();
            this.container.Bind<IExportConditionInterface>()
                        .ToTransient<ExportConditionalObject>()
                        .WhenInjectedInto<ImportConditionObject1>();
            this.container.Bind<IExportConditionInterface>()
                        .ToTransient<ExportConditionalObject2>()
                        .WhenInjectedInto<ImportConditionObject2>();
            this.container.Bind<IExportConditionInterface>()
                        .ToTransient<ExportConditionalObject3>()
                        .WhenInjectedInto<ImportConditionObject3>();
        }

        private void RegisterMultiple()
        {
            this.container.Bind<ISimpleAdapter>().ToTransient<SimpleAdapterOne>();
            this.container.Bind<ISimpleAdapter>().ToTransient<SimpleAdapterTwo>();
            this.container.Bind<ISimpleAdapter>().ToTransient<SimpleAdapterThree>();
            this.container.Bind<ISimpleAdapter>().ToTransient<SimpleAdapterFour>();
            this.container.Bind<ISimpleAdapter>().ToTransient<SimpleAdapterFive>();
            this.container.Bind<ImportMultiple1>().ToTransient<ImportMultiple1>();
            this.container.Bind<ImportMultiple2>().ToTransient<ImportMultiple2>();
            this.container.Bind<ImportMultiple3>().ToTransient<ImportMultiple3>();
        }
    }

    public class ZenjectChildContainerAdapter : IChildContainerAdapter
    {
        private DiContainer childContainer;

        public ZenjectChildContainerAdapter(DiContainer childContainer)
        {
            this.childContainer = childContainer;
        }

        public void Dispose()
        {
        }

        public void Prepare()
        {
            this.childContainer.Bind<ITransient1>().ToTransient<ScopedTransient>();
            this.childContainer.Bind<ICombined1>().ToTransient<ScopedCombined1>();
            this.childContainer.Bind<ICombined2>().ToTransient<ScopedCombined2>();
            this.childContainer.Bind<ICombined3>().ToTransient<ScopedCombined3>();
        }

        public object Resolve(Type resolveType)
        {
            return this.childContainer.Resolve(resolveType);
        }
    }
}

