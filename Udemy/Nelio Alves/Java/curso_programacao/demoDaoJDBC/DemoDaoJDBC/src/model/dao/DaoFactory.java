package model.dao;

import model.dao.molde.dao.impl.SellerDaoJDBC;

public class DaoFactory {
    
    public static SellerDao createSellerDao() {
        return new SellerDaoJDBC();
    }
}
