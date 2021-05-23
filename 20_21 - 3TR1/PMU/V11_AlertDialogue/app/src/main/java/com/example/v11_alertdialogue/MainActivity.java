package com.example.v11_alertdialogue;

import androidx.appcompat.app.AppCompatActivity;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;


public class MainActivity extends AppCompatActivity {

    private static Button MainButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        onButtonClickListener();
    }

    public void onButtonClickListener() {
        MainButton = (Button)findViewById(R.id.button);
        MainButton.setOnClickListener(
                new View.OnClickListener(){
                    @Override
                    public void onClick(View v){
                        AlertDialog.Builder AlertBuilder = new AlertDialog.Builder(MainActivity.this);
                        AlertBuilder.setMessage("Jeste li sugurni da želite izaći iz aplikacije?")
                                .setCancelable(false)
                                .setPositiveButton("Da", new DialogInterface.OnClickListener() {
                                    @Override
                                    public void onClick(DialogInterface dialog, int which) {
                                        finish();
                                    }
                                })
                                .setNegativeButton("Ne", new DialogInterface.OnClickListener() {
                                    @Override
                                    public void onClick(DialogInterface dialog, int which) {
                                        dialog.cancel();
                                    }
                                });
                        AlertDialog alert = AlertBuilder.create();
                        alert.setTitle("Alert");
                        alert.show();
                    }
                }
        );
    }
}