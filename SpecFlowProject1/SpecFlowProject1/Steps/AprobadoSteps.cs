//using Calculos.Negocio;
//using System;
//using TechTalk.SpecFlow;

//namespace SpecFlowProject1.Steps
//{
//    [Binding]
//    public sealed class AprobadoSteps
//    {
//        private readonly ScenarioContext _scenarioContext;
//        Aprobado aprobado;

//        Boolean estado;
//        Boolean rol;
//        Boolean estudiante;
//        int nota1;
//        int nota2;
//        Boolean aprueba;
//        Boolean noAprueba;
//        Boolean promovido;
//        Boolean Nopromovido;


//        public AprobadoSteps(ScenarioContext scenarioContext)
//        {
//            _scenarioContext = scenarioContext;
//            aprobado = new Aprobado();
//        }
//        [Given(@"que que estoy logeado")]
//        public void DadoQueQueEstoyLogeado()
//        {
//            this.estado = true;
//        }
        
//        [Given(@"tengo el perfil de docente")]
//        public void DadoTengoElPerfilDeDocente()
//        {
//            this.rol = true;
//        }
        
//        [Given(@"el estudiante es ""(.*)""")]
//        public void DadoElEstudianteEs()
//        {
//            this.estudiante = true;
//        }
        
//        [Given(@"la nota es (.*)")]
//        public void DadoLaNotaEs(int nota1, int nota2)
//        {
//            this.nota1 = nota1;
//            this.nota2 = nota2;
//        }
        
//        [When(@"aprueba")]
//        public void CuandoAprueba()
//        {
//            this.aprueba = true;
//        }
        
//        [When(@"no aprueba")]
//        public void CuandoNoAprueba()
//        {
//            this.noAprueba = false;
//        }
        
//        [Then(@"el estudiante  es promovido")]
//        public void EntoncesElEstudianteEsPromovido()
//        {
//            Assert
//        }
        
//        [Then(@"el estudiante no es promovido")]
//        public void EntoncesElEstudianteNoEsPromovido()
//        {
//            this.Nopromovido = false;
//        }
//    }
//}
