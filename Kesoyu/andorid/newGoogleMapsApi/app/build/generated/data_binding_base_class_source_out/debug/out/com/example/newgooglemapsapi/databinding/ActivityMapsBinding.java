// Generated by view binder compiler. Do not edit!
package com.example.newgooglemapsapi.databinding;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.FrameLayout;
import android.widget.ListView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.AppCompatImageView;
import androidx.fragment.app.FragmentContainerView;
import androidx.viewbinding.ViewBinding;
import androidx.viewbinding.ViewBindings;
import com.example.newgooglemapsapi.R;
import java.lang.NullPointerException;
import java.lang.Override;
import java.lang.String;

public final class ActivityMapsBinding implements ViewBinding {
  @NonNull
  private final FrameLayout rootView;

  @NonNull
  public final Button btnPhoto;

  @NonNull
  public final Button buttonSendData;

  @NonNull
  public final TextView gpsTextView;

  @NonNull
  public final AppCompatImageView imgView;

  @NonNull
  public final ListView listView;

  @NonNull
  public final RelativeLayout listViewLayout;

  @NonNull
  public final FragmentContainerView map;

  private ActivityMapsBinding(@NonNull FrameLayout rootView, @NonNull Button btnPhoto,
      @NonNull Button buttonSendData, @NonNull TextView gpsTextView,
      @NonNull AppCompatImageView imgView, @NonNull ListView listView,
      @NonNull RelativeLayout listViewLayout, @NonNull FragmentContainerView map) {
    this.rootView = rootView;
    this.btnPhoto = btnPhoto;
    this.buttonSendData = buttonSendData;
    this.gpsTextView = gpsTextView;
    this.imgView = imgView;
    this.listView = listView;
    this.listViewLayout = listViewLayout;
    this.map = map;
  }

  @Override
  @NonNull
  public FrameLayout getRoot() {
    return rootView;
  }

  @NonNull
  public static ActivityMapsBinding inflate(@NonNull LayoutInflater inflater) {
    return inflate(inflater, null, false);
  }

  @NonNull
  public static ActivityMapsBinding inflate(@NonNull LayoutInflater inflater,
      @Nullable ViewGroup parent, boolean attachToParent) {
    View root = inflater.inflate(R.layout.activity_maps, parent, false);
    if (attachToParent) {
      parent.addView(root);
    }
    return bind(root);
  }

  @NonNull
  public static ActivityMapsBinding bind(@NonNull View rootView) {
    // The body of this method is generated in a way you would not otherwise write.
    // This is done to optimize the compiled bytecode for size and performance.
    int id;
    missingId: {
      id = R.id.btnPhoto;
      Button btnPhoto = ViewBindings.findChildViewById(rootView, id);
      if (btnPhoto == null) {
        break missingId;
      }

      id = R.id.buttonSendData;
      Button buttonSendData = ViewBindings.findChildViewById(rootView, id);
      if (buttonSendData == null) {
        break missingId;
      }

      id = R.id.gpsTextView;
      TextView gpsTextView = ViewBindings.findChildViewById(rootView, id);
      if (gpsTextView == null) {
        break missingId;
      }

      id = R.id.imgView;
      AppCompatImageView imgView = ViewBindings.findChildViewById(rootView, id);
      if (imgView == null) {
        break missingId;
      }

      id = R.id.listView;
      ListView listView = ViewBindings.findChildViewById(rootView, id);
      if (listView == null) {
        break missingId;
      }

      id = R.id.listViewLayout;
      RelativeLayout listViewLayout = ViewBindings.findChildViewById(rootView, id);
      if (listViewLayout == null) {
        break missingId;
      }

      id = R.id.map;
      FragmentContainerView map = ViewBindings.findChildViewById(rootView, id);
      if (map == null) {
        break missingId;
      }

      return new ActivityMapsBinding((FrameLayout) rootView, btnPhoto, buttonSendData, gpsTextView,
          imgView, listView, listViewLayout, map);
    }
    String missingId = rootView.getResources().getResourceName(id);
    throw new NullPointerException("Missing required view with ID: ".concat(missingId));
  }
}
