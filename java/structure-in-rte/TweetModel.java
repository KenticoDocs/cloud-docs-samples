// DocSection: structure_in_rte_tweet_model
// Generate strongly typed models at https://github.com/Kentico/kontent-java-packages/tree/master/kontent-delivery-generators
// Tip: Find more about Java SDK at https://docs.kontent.ai/java

import kentico.kontent.delivery.ContentItemMapping;
import kentico.kontent.delivery.ElementMapping;
import kentico.kontent.delivery.Option;
import kentico.kontent.delivery.System;
import java.lang.String;
import java.util.List;

@ContentItemMapping("tweet")
public class Homepage {
    @ElementMapping("tweet_link")
    String tweetLink;

    @ElementMapping("theme")
    List<Option> theme;

    @ElementMapping("display_options")
    List<Option> displayOptions;

    System system;

    public String getTweetLink() {
        return tweetLink;
    }

    public void setTweetLink(String tweetLink) {
        this.tweetLink = tweetLink;
    }

    public List<Option> getTheme() {
        return theme;
    }

    public void setTheme(List<Option> theme) {
        this.theme = theme;
    }

    public List<Option> getDisplayOptions() {
        return displayOptions;
    }

    public void setDisplayOptions(List<Option> displayOptions) {
        this.displayOptions = displayOptions;
    }

    public System getSystem() {
        return system;
    }

    public void setSystem(System system) {
        this.system = system;
    }
}
// EndDocSection