public class Pessoa {
	public void Pessoa(String nome, Logger logger) {
		//Todo o código sobre a pessoa... 
		//// var logger = new Logger('Arquivodelog.txt'); 		
		logger.Log("${nome} foi criada");
	} 
}

//! Constructor injection:
public class PessoaFactory {
  Pessoa GetPessoa(){
    var logger = new Logger();
    
    return new Pessoa("Alberto", logger);
  }
}
public class Pessoa {
	public void Pessoa(String nome, Logger logger) {
		// Não mais novo logger
		//var logger = new Logger(); 		
		logger.Log("${nome} foi criada");
	} 
}

//! Method Injection:
public class PessoaFactory {
  Pessoa GetPessoa(){
    var logger = new Logger();
    var pessoa = new Pessoa();

    pessoa.FazerAlgoComplexo(logger);
    return pessoa;
  }
}
public class Pessoa {
	public void FazerAlgoComplexo(Logger logger) {

		logger.Log("42|1337|muito complexo|matematica");
	} 
}

//! Property Injection:
public class PessoaFactory {
  Pessoa GetPessoa(){
    var logger = new Logger();
    var pessoa = new Pessoa{
      Logger = logger
    };

    pessoa.FazerAlgoComplexo(logger);
    return pessoa;
  }
}
public class Pessoa {
  public Logger Logger {get; set;}
	public void FazerAlgoComplexo(Logger logger) {
		logger.Log("42|1337|muito complexo|matematica");
	} 
}