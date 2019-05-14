package dataAccessLayer;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

import model.Player;

public class GamesDAO {

    private GamesDAO() {
    }

    public static Player insertGame(int playerId, int time ) throws  SQLException{
        Player player = null;
        String query = "INSERT INTO `Player_HighScore` (`player_id`,`highscore`) VALUES (?,?)";

        Connection connection = null;
        PreparedStatement pstmt = null;

        try {
            connection = DAO.getDataSource().getConnection();
            pstmt = connection.prepareStatement(query);
            pstmt.setInt(1, playerId);
            pstmt.setInt(2, time);
            pstmt.executeUpdate();
            //pstmt.executeQuery();
        }
        catch (SQLException e){
            e.printStackTrace();
        }
        finally {
            if (connection != null) {
                connection.close();
            }
        }
		return player;
    }

    public static String[] getTopScorers() throws SQLException {
        
        ArrayList<Map<Integer, Integer>> list = new ArrayList<Map<Integer, Integer>>();
        String query = "SELECT player_id,highscore FROM `Player_HighScore` ORDER BY `highscore` LIMIT 5";

        Connection connection = null;
        PreparedStatement pstmt = null;
        String playerIds="";
        String scores="";
        try {
            connection = DAO.getDataSource().getConnection();
            pstmt = connection.prepareStatement(query);
            ResultSet rs = pstmt.executeQuery();
            
            while (rs.next()) {
                int playerID = rs.getInt("player_id");
                int score = rs.getInt("highscore");
                playerIds+=playerID+",";
                scores+=score+",";
//                Map<Integer, Integer> scoreBoard = new HashMap<Integer, Integer>();
//                scoreBoard.put(playerID,score);
//                list.add(scoreBoard);
            }
//            System.out.println("Value of scoreBoard in list is: "+list);
            rs.close();
            pstmt.close();
        }
        catch (SQLException e) {
            e.printStackTrace();
        }
        finally {
            if (connection != null) {
                connection.close();
            }
        }
        return new String[]{playerIds,scores} ;
    }
}