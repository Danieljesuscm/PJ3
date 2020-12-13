class produto {
  public string nomeproduto;
  public string local;
  public int qntdproduto;
  public string categoria;

  public string Getnomeproduto(){
    return nomeproduto;
  }
  public string  Getlocal() {
   return local;
  }
  public int Getqntdproduto() {
   return qntdproduto;
  }
  public string Getcategoria() {
    return categoria;
  }
  public void Setnomeproduto(string n) {
    nomeproduto=n;
  }
  public void Setcategoria(string c) {
    categoria=c;
  }
  public void Setqntdproduto(int q) {
    qntdproduto=q;
  }
  public void Setlocal(string l) {
    local=l;
  }
  public produto(string n,string l, int q,string c){
    nomeproduto=n;
    local=l;
    qntdproduto=q;
    categoria=c;
  }




}