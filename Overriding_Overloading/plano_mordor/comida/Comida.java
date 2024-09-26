package comida;

public abstract class Comida {
   protected int pontosDeFelicidade;

    public int getPontosDeFelicidade() {
        return pontosDeFelicidade;
    }

    public Comida(int pontosDeFelicidade) {
        this.pontosDeFelicidade = pontosDeFelicidade;
    }
}
