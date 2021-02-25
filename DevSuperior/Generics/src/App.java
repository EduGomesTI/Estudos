import util.List;

public class App {
    public static void main(String[] args) throws Exception {

        List<Double> list = new List<Double>();

        list.add(3.5);
        list.add(9.2);

        System.out.println(list);

        List<String> strList = new List<>();

        strList.add("Eduardo");
        strList.add("Alessandra");
        strList.add("Enzo");

        System.out.println(strList);
    }
}
