package com.example.v2_colorsyes;

import android.graphics.Color;
import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.RadioButton;
import android.widget.LinearLayout;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    boolean isColor = true;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        RadioButton btnBLUE = (RadioButton) findViewById(R.id.btnBLUE);
        RadioButton btnMAGENTA = (RadioButton) findViewById(R.id.btnMAGENTA);
        RadioButton btnYELLOW = (RadioButton) findViewById(R.id.btnYELLOW);

        btnBLUE.setOnClickListener((View.OnClickListener) this);
        btnMAGENTA.setOnClickListener((View.OnClickListener) this);
        btnYELLOW.setOnClickListener((View.OnClickListener) this);
    }

    public void onClick(View view){
        final LinearLayout layout = (LinearLayout) findViewById(R.id.LinearLayout1);

        switch(view.getId()){
            case R.id.btnBLUE:
                layout.setBackgroundColor(Color.BLUE);
                break;

            case R.id.btnMAGENTA:
                layout.setBackgroundColor(Color.MAGENTA);
                break;

            case R.id.btnYELLOW:
                layout.setBackgroundColor(Color.YELLOW);
                break;
        }
    }
}