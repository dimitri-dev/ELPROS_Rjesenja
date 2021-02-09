package com.example.v6_graphicsandsounds;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.SwitchCompat;
import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;
import android.widget.CompoundButton;

public class MainActivity extends AppCompatActivity {

    MediaPlayer sheldon;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Initialize media player with chosen mp3
        sheldon = MediaPlayer.create(this, R.raw.bababababazingaaaaa);

        // Initialize SwitchCompact switch because of android lint error
        SwitchCompat loopSwitch = (SwitchCompat) findViewById(R.id.loopSwitch);

        loopSwitch.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                sheldon.setLooping(isChecked);
            }
        });
    }

    public void playMusic(View view) {
        sheldon.start();
    }
    public void pauseMusic(View view) {
        if (sheldon.isPlaying()) sheldon.pause();
    }
}