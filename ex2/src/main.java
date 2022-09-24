import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import java.util.stream.Collectors;

public class main {
    public static void main(String[] args) {
        List<Short> list = new ArrayList<>(List.of((short)5, (short)15, (short)10 ,(short)5, (short)7, (short)8, (short)40, (short)12));
        Set<Integer> set = new HashSet<>(list.stream().filter(t -> t > 10).map(i -> i+15).collect(Collectors.toSet()));
        for (Integer s : set) {
            System.out.println(s);
        }
    }
}
