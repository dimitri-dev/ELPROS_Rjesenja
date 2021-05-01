package com.example.v9_animalguesser;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.Gravity;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ((Button)findViewById(R.id.chicken)).setOnClickListener(this);
        ((Button)findViewById(R.id.fox)).setOnClickListener(this);
        ((Button)findViewById(R.id.dog)).setOnClickListener(this);
        ((Button)findViewById(R.id.horse)).setOnClickListener(this);
        ((Button)findViewById(R.id.languageSwitch)).setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        switch(v.getId()){
            case R.id.horse:
                Toast.makeText(this, ((Button)findViewById(R.id.horse)).getText().toString(), Toast.LENGTH_SHORT).show();
                break;

            case R.id.fox:
                Toast.makeText(this, ((Button)findViewById(R.id.fox)).getText().toString(), Toast.LENGTH_SHORT).show();
                break;

            case R.id.dog:
                Toast.makeText(this, ((Button)findViewById(R.id.dog)).getText().toString(), Toast.LENGTH_SHORT).show();
                break;

            case R.id.chicken:
                Toast.makeText(this, ((Button)findViewById(R.id.chicken)).getText().toString(), Toast.LENGTH_SHORT).show();
                break;

            case R.id.languageSwitch:
                if (((Button)findViewById(R.id.chicken)).getText().toString() == "Chicken") {
                    ((Button)findViewById(R.id.chicken)).setText("Kokoš");
                    ((Button)findViewById(R.id.dog)).setText("Pas");
                    ((Button)findViewById(R.id.fox)).setText("Lisica");
                    ((Button)findViewById(R.id.horse)).setText("Konj");
                    ((Button)findViewById(R.id.languageSwitch)).setText("English");
                }
                else {
                    ((Button)findViewById(R.id.chicken)).setText("Chicken");
                    ((Button)findViewById(R.id.dog)).setText("Dog");
                    ((Button)findViewById(R.id.fox)).setText("Fox");
                    ((Button)findViewById(R.id.horse)).setText("Horse");
                    ((Button)findViewById(R.id.languageSwitch)).setText("Hrvatski");
                }
                break;
        }
    }
}