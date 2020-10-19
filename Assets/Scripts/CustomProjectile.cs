using UnityEngine;

public class CustomProjectile : MonoBehaviour
{
    //Assignables
    public Rigidbody rb;
    public GameObject explosion;
    public LayerMask whatIsEnemies;

    //Stats
    [Range(0f,1f)]
    public float bounciness;
    public bool useGravity;

    //Damage
    public int explosionDamage;
    public float explosionRange;


    //Lifetime
    public int maxCollisions;
    public float maxLifetime;
    public bool explodeOnTouch = true;

    int collision;
    PhysicMaterial physics_mat;

    private void Start()
    {
        Setup();
    }

    private void Update()
    {
        //Explode
        if (collision > maxCollisions) Explode();

        //Count down lifetime
        maxLifetime -= Time.deltaTime;
        if (maxLifetime <= 0) Explode();
    }

    private void Explode()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        //Count up collisions
        collision++;

        if (coll)
    }

    private void Setup()
    {
        //Create a new Physic material
        physics_mat = new PhysicMaterial();
        physics_mat.bounciness = bounciness;
        physics_mat.frictionCombine = PhysicMaterialCombine.Minimum;
        physics_mat.bounceCombine = PhysicMaterialCombine.Maximum;
        //Assign material to collider
        GetComponent<SphereCollider>().material = physics_mat;

        //Set gravity
        rb.useGravity = useGravity;
    }
}
