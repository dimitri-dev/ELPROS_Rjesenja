package com.example.v10_gestures;

import android.os.Bundle;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.view.GestureDetectorCompat;

import android.view.GestureDetector;
import android.view.MotionEvent;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity
                          implements GestureDetector.OnGestureListener, GestureDetector.OnDoubleTapListener {

    private static TextView MainText;
    private GestureDetectorCompat GestureDetector;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        MainText = (TextView) findViewById(R.id.textView);
        GestureDetector = new GestureDetectorCompat(this, this);
        GestureDetector.setOnDoubleTapListener(this);
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        GestureDetector.onTouchEvent(event);
        return super.onTouchEvent(event);
    }

    @Override
    public boolean onSingleTapConfirmed(MotionEvent e) {
        MainText.setText("Jednostruki pritisak");
        return false;
    }

    @Override
    public boolean onDoubleTap(MotionEvent e) {
        MainText.setText(" Dvostruki pritisak ");
        return false;
    }

    @Override
    public boolean onDoubleTapEvent(MotionEvent e) {
        MainText.setText(" Dvostruki pritisak (Event) ");
        return false;
    }

    @Override
    public boolean onDown(MotionEvent e) {
        MainText.setText(" Dolje ");
        return false;
    }

    @Override
    public void onShowPress(MotionEvent e) {
        MainText.setText(" Prikaz ");
    }

    @Override
    public boolean onSingleTapUp(MotionEvent e) {
        MainText.setText(" Jednostruko prema gore ");
        return false;
    }

    @Override
    public boolean onScroll(MotionEvent ¢1, MotionEvent e2, float distanceX, float distanceY) {
        MainText.setText(" Listanje ");
        return false;
    }

    @Override
    public void onLongPress(MotionEvent ¢) {
        MainText.setText(" Dugi pritisak ");
    }

    @Override
    public boolean onFling(MotionEvent ¢1, MotionEvent e2, float velocityX, float velocityY) {
        MainText.setText(" Prelet ");
        return false;
    }
}
