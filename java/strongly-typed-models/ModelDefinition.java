// DocSection: strongly_typed_models_definition
// Tip: Find more about Java/JavaRx SDKs at https://docs.kontent.ai/java
import kentico.kontent.delivery.Asset;
import kentico.kontent.delivery.ContentItemMapping;
import kentico.kontent.delivery.ElementMapping;
import kentico.kontent.delivery.System;
import java.lang.String;
import java.util.List;

/**
 * This code was generated by a <a href="https://github.com/Kentico/kontent-java-packages/tree/master/kontent-delivery-generators">kontent-generators-java tool</a>
 *
 * Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
 * For further modifications of the class, create a separate file and extend this class.
 */
@ContentItemMapping("homepage")
public class Homepage {
    @ElementMapping("body_text")
    String bodyText;

    @ElementMapping("headline")
    String headline;

    @ElementMapping("picture")
    List<Asset> picture;

    System system;

    public String getBodyText() {
        return bodyText;
    }

    public void setBodyText(String bodyText) {
        this.bodyText = bodyText;
    }

    public String getHeadline() {
        return headline;
    }

    public void setHeadline(String headline) {
        this.headline = headline;
    }

    public List<Asset> getPicture() {
        return picture;
    }

    public void setPicture(List<Asset> picture) {
        this.picture = picture;
    }

    public System getSystem() {
        return system;
    }

    public void setSystem(System system) {
        this.system = system;
    }
}
// EndDocSection