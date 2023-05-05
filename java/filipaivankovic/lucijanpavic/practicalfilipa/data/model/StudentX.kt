package filipaivankovic.lucijanpavic.practicalfilipa.data.model


import com.google.gson.annotations.SerializedName

data class StudentX(
    @SerializedName("age")
    val age: String,
    @SerializedName("description")
    val description: String,
    @SerializedName("name")
    val name: String
)