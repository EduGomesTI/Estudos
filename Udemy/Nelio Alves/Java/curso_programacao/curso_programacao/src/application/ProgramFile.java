package application;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;

public class ProgramFile {
    public static void main(String[] args) {

        // File file = new File("h:\\in.txt");

        // Scanner sc = null;

        // try {
        // sc = new Scanner(file);
        // while (sc.hasNextLine()) {
        // System.out.println(sc.nextLine());
        // }
        // } catch (IOException e) {
        // System.out.println(e.getMessage());
        // } finally {
        // if (sc != null) {
        // sc.close();
        // }
        // }

        // String path = "h:\\in.txt";

        // try (BufferedReader br = new BufferedReader(new FileReader(path))) {

        // String line = br.readLine();

        // while (line != null) {
        // System.out.println(line);
        // line = br.readLine();
        // }
        // } catch (IOException e) {
        // System.out.println(e.getMessage());
        // }
        // String[] lines = new String[] { "Good morning", "Good afternoon", "Good
        // night" };

        // String path = "h:\\out.txt";

        // try (BufferedWriter bw = new BufferedWriter(new FileWriter(path, true))) {
        // for (String line : lines) {
        // bw.write(line);
        // bw.newLine();
        // }
        // } catch (IOException e) {
        // e.printStackTrace();
        // }

        // Scanner sc = new Scanner(System.in);
        // String strPath = sc.nextLine();

        // File path = new File(strPath);

        // File[] folders = path.listFiles(File::isDirectory);

        // for (File folder : folders) {
        //     System.out.println(folder);
        // }

        // File[] files = path.listFiles(File::isFile);

        // for (File file : files) {
        //     System.out.println(file);
        // }

        // boolean sucess = new File(strPath + "\\subdir").mkdir();
        // System.out.println(sucess);

        // sc.close();
    }
}
