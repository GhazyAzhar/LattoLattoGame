package com.bytedance.sdk.openadsdk.unity;

import com.bytedance.sdk.openadsdk.unity.INativeViewIdProvider;

import java.util.ArrayList;
import java.util.List;

/**
 * created by jijiachun on 2022/8/16
 */
public class NativeViewIdProvider implements INativeViewIdProvider {
    @Override
    public String getNativeViewLayoutId() {
        return "native_ad_container";
    }

    @Override
    public List<String> getClickViewIdList() {
        List<String> result = new ArrayList<String>();
        result.add("native_ad_container");//native_ad_container mean whole ad view
        return result;
    }

    @Override
    public List<String> getCreativeViewIdIdList() {
        List<String> result = new ArrayList<String>();
        result.add("native_ad_creative_btn");
        return result;
    }

    @Override
    public String getDislikeViewId() {
        return "native_ad_dislike";
    }

    @Override
    public String getIconViewId() {
        return "native_ad_icon";
    }

    @Override
    public String getTitleViewId() {
        return "native_ad_title";
    }

    @Override
    public String getDescriptionViewId() {
        return "native_ad_desc";
    }

    @Override
    public String getCreativeButton() {
        return "native_ad_creative_btn";
    }

    @Override
    public String getMediaViewIdContainer() {
        return "native_ad_media_container";
    }

    @Override
    public String getAdLogoContainer() {
        return "native_ad_logo";
    }
}
