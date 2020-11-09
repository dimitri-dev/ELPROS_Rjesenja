package com.example.v3_registeruser;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button registerButton = (Button) findViewById(R.id.RegisterButton);
        registerButton.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View v) {
                EditText ime = findViewById(R.id.PersonFirstName);
                EditText prezime = findViewById(R.id.PersonLastName);
                EditText email = findViewById(R.id.PersonEmailAddress);

                TextView showIme = findViewById(R.id.textView);
                TextView showPrezime = findViewById(R.id.textView2);
                TextView showEmail = findViewById(R.id.textView3);

                String wIme = getString(R.string.fName) + ": " + ime.getText();
                String wPrezime = getString(R.string.lName) + ": " + prezime.getText();
                String wEmail = getString(R.string.email) + ": " + email.getText();

                showIme.setText(wIme);
                showPrezime.setText(wPrezime);
                showEmail.setText(wEmail);
            }
        });
    }
}