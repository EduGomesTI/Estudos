package gui;

import java.net.URL;
import java.util.Locale;
import java.util.ResourceBundle;

import gui.util.Alerts;
import gui.util.Constraints;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert.AlertType;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;

public class ViewController implements Initializable {
	
	@FXML
	private TextField txtNumerOne;
	
	@FXML
	private TextField txtNumberTwo;
	
	@FXML
	private Label labelResult;
	
	
	@FXML
	private Button btSum;
	
	@FXML
	public void onBtSumAction() {
		try {
		Locale.setDefault(Locale.US);
		double number1 = Double.parseDouble(txtNumerOne.getText());
		double number2 = Double.parseDouble(txtNumberTwo.getText());
		
		double sum = number1 +  number2;
		
		labelResult.setText(String.format("%.2f", sum));
		}
		catch(NumberFormatException e) {
			Alerts.showAlert("Error", "Parse erro", e.getMessage(), AlertType.ERROR);
		}
	}

	@Override
	public void initialize(URL url, ResourceBundle rb) {
		
		Constraints.setTextFieldDouble(txtNumerOne);
		Constraints.setTextFieldDouble(txtNumberTwo);
		Constraints.setTextFieldMaxLength(txtNumerOne, 12);
		Constraints.setTextFieldMaxLength(txtNumberTwo, 12);
		
	}

}
