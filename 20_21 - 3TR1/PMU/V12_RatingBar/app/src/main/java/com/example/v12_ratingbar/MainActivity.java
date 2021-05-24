package com.example.v12_ratingbar;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RatingBar;
import android.widget.TextView;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {
    private static Button MainButton;
    private static TextView MainText;
    private static RatingBar RatingBar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        listenerOnRatingBar();
        onButtonClickListener();
    }

    public void listenerOnRatingBar(){
        RatingBar = (RatingBar)findViewById(R.id.ratingBar);
        MainText = (TextView)findViewById(R.id.textView);
        RatingBar.setOnRatingBarChangeListener(
                new RatingBar.OnRatingBarChangeListener() {
                    @Override
                    public void onRatingChanged(RatingBar ratingBar, float rating, boolean fromUser) {
                        MainText.setText(String.valueOf(rating));
                    }
                }
        );
    }

    public void onButtonClickListener(){
        RatingBar = (RatingBar)findViewById(R.id.ratingBar);
        MainButton = (Button)findViewById(R.id.button);
        MainButton.setOnClickListener(
                new View.OnClickListener() {
                    @Override
                    public void onClick(View v) {
                        Toast.makeText(MainActivity.this, String.valueOf(RatingBar),Toast.LENGTH_SHORT).show();
                    }
                }
        );
    }
}