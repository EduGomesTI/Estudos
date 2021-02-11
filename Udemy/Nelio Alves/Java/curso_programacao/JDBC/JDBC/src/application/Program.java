package application;

import java.lang.Thread.State;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.SimpleDateFormat;

import db.DB;
import db.DbException;
import db.DbIntegrityException;

public class Program {
    public static void main(String[] args) {

        // SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
        Connection conn = null;
        Statement st = null;
        ResultSet rs = null;
        PreparedStatement ps = null;

        try {
            // * Aula 236
            // conn = DB.getConnection();
            // st = conn.createStatement();
            // rs = st.executeQuery("SELECT * FROM department");

            // while (rs.next()) {
            // System.out.println(rs.getInt("Id") + ", " + rs.getString("Name"));
            // }
            // * Fim da aula 236

            // * Aula 237
            // ps = conn.prepareStatement("INSERT INTO seller " + "(Name, Email, BirthDate,
            // BaseSalary, DepartmentId) "
            // + "VALUES " + "(?, ?, ?, ?, ?)", Statement.RETURN_GENERATED_KEYS);
            // ps.setString(1, "Carl Purple");
            // ps.setString(2, "carl@gmail.com");
            // ps.setDate(3, new java.sql.Date(sdf.parse("22/04/1985").getTime()));
            // ps.setDouble(4, 3000.0);
            // ps.setInt(5, 4);

            // ps = conn.prepareStatement("INSERT INTO department (Name) VALUES ('D1'),
            // ('D2')",
            // Statement.RETURN_GENERATED_KEYS);

            // int rowsAffected = ps.executeUpdate();

            // if (rowsAffected > 0) {
            // ResultSet rsKey = ps.getGeneratedKeys();
            // while (rsKey.next()) {
            // int id = rsKey.getInt(1);
            // System.out.println("Done! Id = " + id);
            // }
            // } else {
            // System.out.println("No rows affected!");
            // }

            // * Fim da aula 237

            // * Aula 238
            // conn = DB.getConnection();
            // ps = conn.prepareStatement(
            // "UPDATE seller " + "SET BaseSalary = BaseSalary + ? " + "WHERE " +
            // "(DepartmentId = ?)");
            // ps.setDouble(1, 200.0);
            // ps.setInt(2, 2);

            // int rowsAffected = ps.executeUpdate();

            // System.out.println("Done! Rows affected: " + rowsAffected);

            // * Fim da aula 238

            // * Aula 239
            // conn = DB.getConnection();
            // ps = conn.prepareStatement("DELETE FROM department " + "WHERE " + "Id = ?");

            // ps.setInt(1, 5);

            // int rowsAffected = ps.executeUpdate();

            // System.out.println("Done! Rows affected: " + rowsAffected);

            // * Fim da aula 239

            // * Aula 240
            conn = DB.getConnection();

            conn.setAutoCommit(false);

            st = conn.createStatement();

            int rows1 = st.executeUpdate("UPDATE seller SET BaseSalary = 2090 WHERE DepartmentId = 1");

            // int x = 1;
            // if (x < 2) {
            // throw new SQLException("Fake error.");
            // }

            int rows2 = st.executeUpdate("UPDATE seller SET BaseSalary = 3090 WHERE DepartmentId = 2");

            conn.commit();

            System.out.println("rows1: " + rows1);
            System.out.println("rows2: " + rows2);

            // * Fim da aula 240

        } catch (SQLException e) {
            try {
                conn.rollback();
                throw new DbException("Transaction rolled back! Caused by: " + e.getMessage());
            } catch (SQLException e1) {
                throw new DbException("Error trying to rollback! Caused by: " + e1.getMessage());
            }
        }
        // catch (ParseException e) {
        // e.printStackTrace();
        // }
        finally {
            DB.closeResultSet(rs);
            DB.closeStatement(st);
            DB.closeStatement(ps);
            DB.closeConnection();
        }
    }
}
