// Letra: A
class Aeronave{
  // Letra: A 
  private string NomeAeronave;
  private int    CapacidadeTanqueCombustivel;
  private int    NivelCombustivelAtual;
  private int    QtdPassageiros;
  private int    AutonomiaAeronave;
  private int    HorasDeVoo;
  private string NomePiloto;
  private string AeroportoAtual;

  // Letra: E
  public Aeronave(  ){  }

  // Letra: E
  public Aeronave( string _NomeAeronave, 
                   int    _CapacidadeTanqueCombustivel, 
                   int    _NivelCombustivelAtual, 
                   int    _QtdPassageiros, 
                   int    _AutonomiaAeronave, 
                   int    _HorasDeVoo,  
                   string _NomePiloto,  
                   string _AeroportoAtual ) {
    NomeAeronave                = _NomeAeronave;
    CapacidadeTanqueCombustivel = _CapacidadeTanqueCombustivel;
    NivelCombustivelAtual       = _NivelCombustivelAtual;
    QtdPassageiros              = _QtdPassageiros;
    AutonomiaAeronave           = _AutonomiaAeronave;
    HorasDeVoo                  = _HorasDeVoo;
    NomePiloto                  = _NomePiloto;
    AeroportoAtual              = _AeroportoAtual;
  }

  
  
  // Letra: D
  public string Nome{
    get { return NomePiloto; }
    set { NomePiloto = value; }
  }
  // Letra: D
  public string Aeroporto{
    get { return AeroportoAtual; }
    set { AeroportoAtual = value; }
  }
  
  // Letra: B
  public int AbastecerAeronave(  ) {
    return CapacidadeTanqueCombustivel - NivelCombustivelAtual;
  }

  // Letra: C
  public int Voar( int distancia ){
    if( distancia <= AutonomiaAeronave ) {
      HorasDeVoo += distancia;
    }
    return HorasDeVoo;
  }

  

}
