public class Retangulo extends FormaGeometrica{
    protected double largura;
    protected double altura;

    public double getLargura() {
        return largura;
    }

    public double getAltura() {
        return altura;
    }

    public void setLargura(double largura) {
        if (largura < 0){
            throw new IllegalArgumentException("Largura deve ser maior ou igual a 0");
        } else {
            this.largura = largura;
        }
    }

    public void setAltura(double altura) {
        if (altura < 0){
            throw new IllegalArgumentException("Altura deve ser maior ou igual a 0");
        } else {
            this.altura = altura;
        }
    }

    @Override
    public double area(){
        return getLargura() * getAltura();
    }

    @Override
    public String toString() {
        return String.format("[Retangulo] %.02f / %.02f", largura, altura);
    }
}